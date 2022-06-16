import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CategoryFilterComponent } from './categoryFilter.component';
import { PaginationComponent } from './pagination.component';
import { UserListComponent } from './userList.component';
import { UserSelectionComponent } from './userSelection.component';

@NgModule({
  declarations: [
    CategoryFilterComponent,
    PaginationComponent,
    UserListComponent,
    UserSelectionComponent,
  ],
  imports: [BrowserModule],
  exports: [UserSelectionComponent, CategoryFilterComponent],
})
export class SpaModule {}
