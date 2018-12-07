import { Trainee } from './../trainee';
import { Component, OnInit } from '@angular/core';
import { TraineeService } from '../trainee.service';
import { HttpClient, HttpHeaders} from '@angular/common/http';

@Component({
  selector: 'app-trainee-insert',
  templateUrl: './trainee-insert.component.html',
  styleUrls: ['./trainee-insert.component.css']
})
export class TraineeInsertComponent implements OnInit {


  constructor(private traineeservice: TraineeService, private http: HttpClient) { }

  trainee: Trainee;
  trainees: Trainee[];
  ngOnInit() {
      this.newBatch();
      this.getTrainees();
    }

  newBatch(): void {
      this.trainee = {
        TraineeId: null,
        TraineeName: '',
        Specialization: ''
      };
  }


  getTrainees(): void {
    this.traineeservice.getTraineesSer()
    .subscribe(trainees => this.trainees = trainees);
     }


  saveTraineeData(): void {
    console.log('Save Contact Data');
    const header = new HttpHeaders({'Content-Type': 'application/json'});
    this.http.post<Trainee>('http://localhost:54420/api/trainees', this.trainee, {headers: header})
    .subscribe(t => this.trainees.push(t));
    }

}
