import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Meeting } from '../_models/meeting';

@Injectable({
  providedIn: 'root'
})
export class MeetingService {

	baseUrl = environment.apiUrl;

	constructor(private http: HttpClient) { }

	getMeetings(): Observable<Meeting[]>  {
		return this.http.get<Meeting[]>(this.baseUrl + 'meeting');
	}

	getMeeting(id): Observable<Meeting> {
		return this.http.get<Meeting>(this.baseUrl + 'meeting/' + id);
	}

}
