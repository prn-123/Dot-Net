import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { HttpClientModule} from '@angular/common/http';
import {RouterModule} from '@angular/router';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { ContactComponent } from './contact/contact.component';
import { ContactService } from './contact.service';
import { ContactDetailComponent } from './contact-detail/contact-detail.component';
import { ContactInsertComponent } from './contact-insert/contact-insert.component';

@NgModule({
  declarations: [
    AppComponent,
    ContactComponent,
    ContactDetailComponent,
    ContactInsertComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([{path: 'contacts', component: ContactComponent},
    {path: 'detail/:id', component: ContactDetailComponent},
    {path: 'insert', component: ContactInsertComponent}])
  ],
  providers: [ContactService],
  bootstrap: [AppComponent]
})
export class AppModule { }
