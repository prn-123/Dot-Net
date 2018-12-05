import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import { Contact } from './contact';


@Injectable({
  providedIn: 'root'
})
export class ContactService {

  contact: Contact;
  contacts: Contact[];

  constructor(private http: HttpClient) { }

  getContactsSer(): Observable<Contact[]> {
    return this.http.get<Contact[]>('http://localhost:58977/api/Contacts');
  }

  getDetailContact(id: number): Observable<Contact> {
    return this.http.get<Contact>('http://localhost:58977/api/Contacts/' + id);
  }

  saveData(contact: Contact): Observable<Contact> {
    const header = new HttpHeaders({'Content-Type': 'application/json'});
    return this.http.post<Contact>('http://localhost:58977/api/Contacts', contact, {headers: header});
  }
}
