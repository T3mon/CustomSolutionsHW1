import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { PublicData } from './PublicData';

@Component({
  selector: 'app-public-data',
  templateUrl: './public-data.component.html',
  styleUrls: ['./public-data.component.css']
})

export class PublicDataComponent implements OnInit {

  public publicDataset: Array<PublicData>;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Array<PublicData>>(baseUrl + 'publicdata/get-publicdata').subscribe(
      result => {
        this.publicDataset = result;
      },
      error => {
        console.log("publicData error: " + error);
      }
    );

  }

  ngOnInit() {
  }

}
