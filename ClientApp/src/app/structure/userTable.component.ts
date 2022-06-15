import { Component } from '@angular/core';
import { Repository } from '../models/repository';
import { Users } from '../models/User.model';
import { Router } from '@angular/router';

@Component({
  selector: 'user-table',
  templateUrl: 'userTable.component.html',
})
export class UserTableComponent {
  /**
   *
   */

  constructor(private repo: Repository, private router: Router) {}
  get users(): Users[] {
    debugger;
    return this.repo.users;
  }
}
