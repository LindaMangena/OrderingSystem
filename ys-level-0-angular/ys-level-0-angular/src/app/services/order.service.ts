import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Order } from '../_shared/models/order.model';
import { Response } from '../_shared/models';






@Injectable({
  providedIn: 'root'
})
export class OrderService {
  baseUrl = "http://localhost:53494/api"

  constructor(private http: HttpClient) { }

  

  public createOrder(data): any {
    console.log('This is service',data)
    return this.http.post(`${this.baseUrl}/create_order`, data);
  }

  getOrderByEmail(email){
    return this.http.get<Response<Order[]>>(`${this.baseUrl}/orders?senderemail=${email}`);

  }

}
