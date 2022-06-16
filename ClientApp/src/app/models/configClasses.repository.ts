export class Filter {
  category?: string;
  search?: string;
  root?: string;
  related: boolean = false;

  reset() {
    this.category = this.search = null;
    this.root = null;
    this.related = false;
  }
}

export class Pagination {
  usersPerPage: number = 15;
  currentPage = 1;
}
