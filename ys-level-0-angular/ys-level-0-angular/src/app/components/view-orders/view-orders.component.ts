import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OrderService } from 'src/app/services/order.service';
import { Order } from 'src/app/_shared/models/order.model';
import { Response } from 'src/app/_shared/models';

@Component({
  selector: 'app-view-orders',
  templateUrl: './view-orders.component.html',
  styleUrls: ['./view-orders.component.scss']
})
export class ViewOrdersComponent implements OnInit {
  senderEmail: string;
  
  loading: any = false;
  orders:Order[] = [];
  constructor(private orderService: OrderService, private router:Router) { }



  ngOnInit(): void {
  //  this.getOrderByEmail(this.senderEmail);
  }
  getOrderByEmail(senderEmail:string){
    this.orderService.getOrderByEmail(senderEmail).subscribe(reponse => {
      
      console.log(reponse);
      this.orders = reponse.data;
      // console.log(senderEmail)
      this.router.navigateByUrl('/orderHistory');
      this.orders = reponse.data;
      
      
    },error=>console.log(error));;
    console.log(senderEmail)

  }



}
