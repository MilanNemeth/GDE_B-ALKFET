import { Component } from '@angular/core';
import { MessageService } from '../message-service';

@Component({
  selector: 'app-messages',
  imports: [],
  templateUrl: './messages.html',
  styleUrl: './messages.scss',
})
export class Messages {
  constructor(public messageService: MessageService) { }
}