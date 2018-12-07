import { TraineeInsertComponent } from './trainee-insert/trainee-insert.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TraineeComponent } from './trainee/trainee.component';
import { TraineeDetailComponent } from './trainee-detail/trainee-detail.component';

const routes: Routes = [{path: 'trainee', component: TraineeComponent},
{path: 'traineedetail/:id', component: TraineeDetailComponent},
{path: 'traineeinsert', component: TraineeInsertComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
