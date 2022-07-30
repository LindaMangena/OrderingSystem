import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  model: any = {};
  items = [{
    name: 'pizza',
    price: 120,
    image: '../../../assets/images/Item3.jpg'

  },
  {
    name: 'steak',
    price: 100,
    image: '../../../assets/images/Item2.jpg'

  },
  {
    name: 'Juice',
    price: 50,
    image: '../../../assets/images/Item1.jpg'
  }

  ];


  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  btnClick(item) {
    console.log(item);
    this.router.navigateByUrl('/orderItem',{state: {item}});
  }


}
