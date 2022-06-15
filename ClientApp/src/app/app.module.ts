import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModelModule } from './models/model.module';
import { UserTableComponent } from './structure/userTable.component';
import { UserPCsTableComponent } from './structure/userPCsTable.component';

@NgModule({
  declarations: [AppComponent, UserTableComponent, UserPCsTableComponent],
  imports: [BrowserModule, AppRoutingModule, ModelModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
