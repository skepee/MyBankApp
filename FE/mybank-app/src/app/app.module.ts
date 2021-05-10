import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'; 
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BalanceComponent } from './balance/balance.component';
import { RouterModule } from '@angular/router';
import { TransactionComponent } from './transaction/transaction.component';
import { DepositComponent } from './deposit/deposit.component';

@NgModule({
  declarations: [
    AppComponent,
    BalanceComponent,
    TransactionComponent,
    DepositComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: 'balance', component: BalanceComponent},
      {path: 'transaction', component: TransactionComponent},
      {path: 'deposit', component: DepositComponent},
    ]),
    FormsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
