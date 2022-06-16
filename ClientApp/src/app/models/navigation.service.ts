import { Injectable } from '@angular/core';
import { Router, ActivatedRoute, NavigationEnd } from '@angular/router';
import { Repository } from '../models/repository';
import { filter } from 'rxjs/operators';

@Injectable()
export class NavigationService {
  constructor(
    private repository: Repository,
    private router: Router,
    private active: ActivatedRoute
  ) {
    router.events
      .pipe(filter((event) => event instanceof NavigationEnd))
      .subscribe((ev) => this.handleNavigationChange());
  }

  private handleNavigationChange() {
    let active = this.active.firstChild.snapshot;

    if (active.url.length > 0 && active.url[0].path === 'spa') {
      this.repository.filter.root = 'spa';
      if (active.params['categoryOrPage'] !== undefined) {
        let value = Number.parseInt(active.params['categoryOrPage']);
        if (!Number.isNaN(value)) {
          this.repository.filter.category = '';
          this.repository.paginationObject.currentPage = value;
        } else {
          this.repository.filter.category = active.params['categoryOrPage'];
          this.repository.paginationObject.currentPage = 1;
        }
      } else {
        let category = active.params['category'];
        this.repository.filter.category = category || '';
        this.repository.paginationObject.currentPage =
          Number.parseInt(active.params['page']) || 1;
      }
      this.repository.getUsers();
    } else if (active.url.length > 0 && active.url[0].path === 'pcs') {
      this.repository.filter.root = 'pcs';
      if (active.params['categoryOrPage'] !== undefined) {
        let value = Number.parseInt(active.params['categoryOrPage']);
        if (!Number.isNaN(value)) {
          this.repository.filter.category = '';
          this.repository.paginationObject.currentPage = value;
        } else {
          this.repository.filter.category = active.params['categoryOrPage'];
          this.repository.paginationObject.currentPage = 1;
        }
      } else {
        let category = active.params['category'];
        this.repository.filter.category = category || '';
        this.repository.paginationObject.currentPage =
          Number.parseInt(active.params['page']) || 1;
      }
      this.repository.getUserPCs();
    } else if (active.url.length > 0 && active.url[0].path === 'statistic') {
      this.repository.filter.root = 'statistic';
      let category = active.params['category'];
      this.repository.filter.category = category || '';
      this.repository.getStatistic();
    }
  }

  get categories(): string[] {
    return this.repository.categories;
  }

  get currentCategory(): string {
    return this.repository.filter.category;
  }
  get currentRoute(): string {
    return this.repository.filter.root;
  }

  set currentCategory(newCategory: string) {
    let myUrl = this.active.firstChild.snapshot.url[0].path;
    if (myUrl === 'spa') {
      this.repository.filter.root = 'spa';
      this.router.navigateByUrl(`/spa/${(newCategory || '').toLowerCase()}`);
    } else if (myUrl === 'pcs') {
      this.repository.filter.root = 'pcs';
      this.router.navigateByUrl(`/pcs/${(newCategory || '').toLowerCase()}`);
    } else {
      this.repository.filter.root = 'statistic';
      this.router.navigateByUrl(
        `/statistic/${(newCategory || '').toLowerCase()}`
      );
    }
  }

  get currentPage(): number {
    return this.repository.paginationObject.currentPage;
  }

  set currentPage(newPage: number) {
    let myUrl = this.active.firstChild.snapshot.url[0].path;
    if (this.currentCategory === '') {
      this.router.navigateByUrl(`/${myUrl}/${newPage}`);
    } else {
      this.router.navigateByUrl(`/${myUrl}/${this.currentCategory}/${newPage}`);
    }
  }

  get usersPerPage(): number {
    return this.repository.paginationObject.usersPerPage;
  }

  get usersCount(): number {
    if (this.active.firstChild.snapshot.url[0].path === 'pcs') {
      return (this.repository.userPCs || []).length;
    }
    return (this.repository.users || []).length;
  }
}
