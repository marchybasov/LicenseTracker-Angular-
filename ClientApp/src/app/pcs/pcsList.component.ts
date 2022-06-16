import { Component } from '@angular/core';
import { Repository } from '../models/repository';
import { UserPCs } from '../models/UserPC.model';
import { Router } from '@angular/router';

@Component({
  selector: 'pcs-list',
  templateUrl: 'pcsList.component.html',
})
export class PcsListComponent {
  constructor(private repo: Repository) {}
  get pcs(): UserPCs[] {
    if (this.repo.userPCs != null && this.repo.userPCs.length > 0) {
      let pageIndex =
        (this.repo.paginationObject.currentPage - 1) *
        this.repo.paginationObject.usersPerPage;
      return this.repo.userPCs.slice(
        pageIndex,
        pageIndex + this.repo.paginationObject.usersPerPage
      );
    }
    return this.repo.userPCs;
  }
}
