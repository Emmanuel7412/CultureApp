import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title: string = 'NgClient';

  users: any;
  constructor(private http: HttpClient) {
  }
  ngOnInit(): void {
    this.http.get('https://localhost:7167/api/users')
      .subscribe({
        next: result => this.users = result,
        error: error => console.log(error),
        complete: () => console.log('Request has completed')
      }
      );

  }
}
