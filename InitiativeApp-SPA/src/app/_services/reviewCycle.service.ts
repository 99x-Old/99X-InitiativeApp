import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ReviewCycle } from '../_models/reviewCycle';

@Injectable({
  providedIn: 'root'
})
export class ReviewCycleService {

	baseUrl = environment.apiUrl;

	constructor(private http: HttpClient) { }

	getReviewCycles(): Observable<ReviewCycle[]>  {
		return this.http.get<ReviewCycle[]>(this.baseUrl + 'reviewCycle');
	}

	getReviewCycle(id): Observable<ReviewCycle> {
		return this.http.get<ReviewCycle>(this.baseUrl + 'reviewCycle/' + id);
	}


}
