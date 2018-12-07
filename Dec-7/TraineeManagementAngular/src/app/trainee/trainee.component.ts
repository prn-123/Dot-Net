import { Trainee } from './../trainee';
import { Component, OnInit } from '@angular/core';
import { TraineeService } from '../trainee.service';

@Component({
  selector: 'app-trainee',
  templateUrl: './trainee.component.html',
  styleUrls: ['./trainee.component.css']
})
export class TraineeComponent implements OnInit {

  trainees: Trainee[];
  constructor(private traineeService: TraineeService) { }

  ngOnInit() {
    this.traineeService.getTraineesSer().subscribe(t => this.trainees = t);
  }
}
