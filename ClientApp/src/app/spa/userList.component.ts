import { Component } from '@angular/core';
import { Repository } from '../models/repository';
import { Users } from '../models/User.model';

import { Router } from '@angular/router';

@Component({
  selector: 'spa-user-list',
  templateUrl: 'userList.component.html',
})
export class UserListComponent {
  constructor(private repo: Repository) {}
  get users(): Users[] {
    if (this.repo.users != null && this.repo.users.length > 0) {
      let pageIndex =
        (this.repo.paginationObject.currentPage - 1) *
        this.repo.paginationObject.usersPerPage;
      return this.repo.users.slice(
        pageIndex,
        pageIndex + this.repo.paginationObject.usersPerPage
      );
    }
    return this.repo.users;
  }
}
