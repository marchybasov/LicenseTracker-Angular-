import { Component } from '@angular/core';
import { Repository } from '../models/repository';
import { UserPCs } from '../models/UserPC.model';
import { Router } from '@angular/router';

@Component({
  selector: 'user-detail',
  templateUrl: 'userPCsTable.component.html',
})
export class UserPCsTableComponent {
  constructor(private repo: Repository, private router: Router) {}

  get userPCs(): UserPCs[] {
    return this.repo.userPCs;
  }
}
