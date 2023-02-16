import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/homeModels';

@Injectable()
export class HomeService {
    constructor(@Inject(HttpClient) private httpClient: HttpClient) {

    }

    async saveUser(user: User): Promise<any> {
        await this.httpClient.post('/user', user).subscribe(result => {
            return result;
        }, error => { return Promise.reject(error) });
    }
}