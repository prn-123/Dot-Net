import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contact } from '../contact';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
contacts: Contact[];
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get<Contact[]>('http://localhost:53325/api/contacts')
    .subscribe(contacts => this.contacts = contacts);

  }


}
