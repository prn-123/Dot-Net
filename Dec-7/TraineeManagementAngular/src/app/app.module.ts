import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TraineeComponent } from './trainee/trainee.component';
import { TraineeDetailComponent } from './trainee-detail/trainee-detail.component';
import { TraineeInsertComponent } from './trainee-insert/trainee-insert.component';

@NgModule({
  declarations: [
    AppComponent,
    TraineeComponent,
    TraineeDetailComponent,
    TraineeInsertComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
