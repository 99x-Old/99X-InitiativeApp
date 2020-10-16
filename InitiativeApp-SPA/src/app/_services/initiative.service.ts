import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Initiative } from '../_models/initiative';

@Injectable({
	providedIn: 'root'
})
export class InitiativeService {

	baseUrl = environment.apiUrl;

	constructor(private http: HttpClient) { }

	getInitiatives(): Observable<Initiative[]>  {
		return this.http.get<Initiative[]>(this.baseUrl + 'initiative');
	}

	getInitiative(id): Observable<Initiative> {
		return this.http.get<Initiative>(this.baseUrl + 'initiative/' + id);
	}
}
