import { DatePipe } from '@angular/common';
import { Pipe, PipeTransform } from '@angular/core';
import { DateFormat } from '../class-support/date-format/date-format';

@Pipe({
  name: 'dateFormat'
})
export class DateFormatPipe extends DatePipe implements PipeTransform {

  override transform(value: any): any {
    return super.transform(value, DateFormat.dateFormat)
  }

}
