import { Component, Inject, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { OrderService } from "src/app/services/order.service";
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: "app-order-item",
  templateUrl: "./order-item.component.html",
   
  styleUrls: ["./order-item.component.scss"]
})
export class OrderItemComponent implements OnInit {
  
  data: any;
  iprice: any;
  item: any;
  
  // @Inject(ToastrService) private toastrService;
  constructor(
    private router: Router, 
    private orderService: OrderService,
 
     
    
    ) 
    
  {
    this.data = this.router.getCurrentNavigation().extras.state.item;
    this.item = this.data.name;
    this.iprice = this.data.price;
  }

  ngOnInit(): void {}

  submit(f) {

    if (f.value.invalid){
      return
    }
    console.log(f.value);

    this.orderService.createOrder(f.value).subscribe(data => {
       alert('Order successfully placed!');

      //  this.toastr.success("Order successfuly placed");

      this.router.navigateByUrl('/orderHistory')
       

      console.log(data);
    }, error =>{
      console.log(error)
      alert('Please fill in the Form');
      // this.toastr.error("Please fill in the Form");
    });
  }
}
