import { HttpClient } from '@angular/common/http';
import { TraineeService } from './../trainee.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Trainee } from '../trainee';

@Component({
  selector: 'app-trainee-detail',
  templateUrl: './trainee-detail.component.html',
  styleUrls: ['./trainee-detail.component.css']
})
export class TraineeDetailComponent implements OnInit {

  Trainee: Trainee;
  constructor( private http: HttpClient, private route: ActivatedRoute) { }

  ngOnInit() {

    const id = +this.route.snapshot.paramMap.get('id');
    this.http.get<Trainee>('http://localhost:54420/api/trainees/' + id)
    .subscribe(t => this.Trainee = t);
  }

}

