import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserTableComponent } from './structure/userTable.component';
import { UserPCsTableComponent } from './structure/userPCsTable.component';
import { BrowserModule } from '@angular/platform-browser';

const routes: Routes = [
  { path: 'users', component: UserTableComponent },
  { path: 'pcs', component: UserPCsTableComponent },
  { path: '', component: UserPCsTableComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
