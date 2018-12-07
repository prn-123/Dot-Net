import { Component, OnInit } from '@angular/core';
import { Contact } from '../contact';
import {HttpClient, HttpHeaders} from '@angular/common/http';
@Component({
  selector: 'app-add-contact',
  templateUrl: './add-contact.component.html',
  styleUrls: ['./add-contact.component.css']
})
export class AddContactComponent implements OnInit {

  contact: Contact;
  contacts: Contact[];
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.newContact();
    this.getContact();
  }
  getContact(): any {
    this.http.get<Contact[]>('http://localhost:53325/api/contacts')
    .subscribe(contacts => this.contacts = contacts);

  }

  newContact(): void {
    this.contact = {
      ContactId: null,
      ContactName: '',
      Location: '',
      CurrentLocation: ''
    };
  }
  saveContactData(): void {
    const header = new HttpHeaders({'Content-Type': 'application/json'});
     this.http.post<Contact>('http://localhost:53325/api/contacts', this.contact, {headers: header})
     .subscribe(c => this.contacts.push(c));
     console.log('Saved');
  }
}
