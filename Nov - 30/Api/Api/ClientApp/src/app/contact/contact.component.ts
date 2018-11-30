import { Component, OnInit } from '@angular/core';
import { Contact } from '../contact';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  contact: Contact[];
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get<Contact[]>("https://localhost:44385/api/Contact")//Controlelr contact
      .subscribe(cont => this.contact = cont);
  }

}
