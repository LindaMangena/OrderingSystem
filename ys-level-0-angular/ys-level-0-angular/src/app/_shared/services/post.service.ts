import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { Post, Response } from '../models';

@Injectable({
  providedIn: 'root'
})
export class PostService {
  baseUrl: string = 'https://jsonplaceholder.typicode.com';

  constructor(
    private http: HttpClient
  ) { }

  createPost(post: Post): Observable<Response<void>> {
    return this.http
      .post(`${this.baseUrl}/posts`, post)
      .pipe(map(data => ({} as Response<void>))); //// do not put this line on  your code; this only maps the external response to response that our API (backend) returns
  }

  getPosts(): Observable<Response<Post[]>> {
    return this.http
      .get<Post[]>(`${this.baseUrl}/posts`)
      .pipe(map(data => ({ data } as Response<Post[]>))); //// do not put this line on  your code; this only maps the external response to response that our API (backend) returns
  }
}
