
import { ContactService } from './../contact.service';
import { Component, OnInit } from '@angular/core';
import { Contact } from '../contact';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  contacts: Contact[];
  constructor(private contactServive: ContactService) { }

  ngOnInit() {
    this.contactServive.getContacts().subscribe(cont => this.contacts = cont);
  }

}

