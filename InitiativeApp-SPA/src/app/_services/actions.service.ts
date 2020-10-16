import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Actions } from '../_models/actions';

@Injectable({
  providedIn: 'root'
})
export class ActionsService {

	baseUrl = environment.apiUrl;

	constructor(private http: HttpClient) { }

	getActions(): Observable<Actions[]> { 
		return this.http.get<Actions[]>(this.baseUrl + 'action');
	}

	getAction(id): Observable<Actions> {
		return this.http.get<Actions>(this.baseUrl + 'action/' + id);
	}

}
