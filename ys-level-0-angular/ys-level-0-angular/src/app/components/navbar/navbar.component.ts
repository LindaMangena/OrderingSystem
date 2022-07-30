import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { OrderService } from 'src/app/services/order.service';
import { Order } from 'src/app/_shared/models/order.model';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {
  orders:Order[]=[]
 
  SenderEmail : string ;
  

  constructor(private orderService: OrderService, private router:Router) { }
  

  ngOnInit(): void {
  }

  getOrderByEmail(senderEmail:string){
    this.orderService.getOrderByEmail(senderEmail).subscribe(reponse => {
      console.log(reponse);
      this.orders = reponse.data;
      // console.log(senderEmail)
      this.router.navigateByUrl('/orderHistory');
      
      
    },error=>console.log(error));;
    console.log(senderEmail)

  }
}
