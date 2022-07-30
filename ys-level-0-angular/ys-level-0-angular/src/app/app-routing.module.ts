import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./components/home/home.component";
import { OrderItemComponent } from "./components/order-item/order-item.component";
import { ViewOrdersComponent } from "./components/view-orders/view-orders.component";

import { LoginComponent } from "./login/login.component";
import { PostFormComponent } from "./post-form/post-form.component";
import { PostsComponent } from "./posts/posts.component";

const routes: Routes = [
  {
    path: "login",
    component: LoginComponent,
  },
  {
    path: "orderItem",
    component: OrderItemComponent,
  },

  {
    path: "posts",
    component: PostsComponent,
  },
  {
    path: "orderHistory",
    component: ViewOrdersComponent,
  },
  {
    path: "post-form",
    component: PostFormComponent,
  },
  {
    path: "home",
    component: HomeComponent,
  },
  {
    path: "",
    pathMatch: "full",
    redirectTo: "home",
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: "legacy" })],
  exports: [RouterModule],
})
export class AppRoutingModule {}
