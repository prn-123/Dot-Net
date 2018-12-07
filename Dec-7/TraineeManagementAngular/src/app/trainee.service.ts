import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Trainee } from './trainee';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TraineeService {


  constructor(private http: HttpClient) { }


  getTraineesSer(): any {
    return this.http.get<Trainee[]>('http://localhost:54420/api/trainees');
  }
  // saveData(trainee: Trainee): Observable<Trainee> {
  //   const header = new HttpHeaders({'Content-Type': 'application/json'});
  //   return this.http.post<Trainee>('http://localhost:54420/api/trainees', trainee, {headers: header});
  // }
}
