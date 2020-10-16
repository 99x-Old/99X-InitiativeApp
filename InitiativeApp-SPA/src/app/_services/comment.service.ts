import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
	providedIn: 'root'
})
export class CommentService {

	baseUrl = environment.apiUrl;

	constructor(private http: HttpClient) { }

	getComments(): Observable<Comment[]>  {
		return this.http.get<Comment[]>(this.baseUrl + 'comment');
	}

	getComment(id): Observable<Comment> {
		return this.http.get<Comment>(this.baseUrl + 'comment/' + id);
	}

}
