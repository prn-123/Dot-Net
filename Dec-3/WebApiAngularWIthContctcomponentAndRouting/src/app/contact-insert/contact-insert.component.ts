import { Component, OnInit } from '@angular/core';
import { Contact } from '../contact';
import { ContactService } from '../contact.service';

@Component({
  selector: 'app-contact-insert',
  templateUrl: './contact-insert.component.html',
  styleUrls: ['./contact-insert.component.css']
})
export class ContactInsertComponent implements OnInit {

  constructor(private contactservice: ContactService) { }


  contact: Contact;
  contacts: Contact[];
  ngOnInit() {
      this.newBatch();
      this.getContacts();
    }

  newBatch(): void {
      this.contact = {
        ContactId: null,
        ContactName: '',
        Location: ''
      };
  }

  getContacts(): void {
    this.contactservice.getContactsSer()
    .subscribe(contacts => this.contacts = contacts);
     }


  saveContactData(): void {
    console.log('Save Contact Data');
    this.contactservice.saveData(this.contact)
    .subscribe(b => this.contacts.push(b));
    }
}

