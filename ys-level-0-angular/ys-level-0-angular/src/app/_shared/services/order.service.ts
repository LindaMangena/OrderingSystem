import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  baseUrl: string = 'http://localhost:53494/api';

  constructor(private http: HttpClient) { }

  createOrder(order: any): any {
    return this.http.post(`${this.baseUrl}/create_order`, order);
  }

  getOrderByEmail(SenderEmail: string): any {

    return this.http.get(`${this.baseUrl}orders?SenderEmail=${SenderEmail}`);

  }
}
