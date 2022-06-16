import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModelModule } from './models/model.module';
// import { UserTableComponent } from './structure/userTable.component';
// import { UserPCsTableComponent } from './structure/userPCsTable.component';
import { SpaModule } from './spa/spa.module';
import { FormsModule } from '@angular/forms';
import { StatisticModule } from './statistic/statistic.module';
import { PcsModule } from './pcs/pcs.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ModelModule,
    FormsModule,
    SpaModule,
    StatisticModule,
    PcsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
