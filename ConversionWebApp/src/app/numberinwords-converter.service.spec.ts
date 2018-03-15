import { TestBed, inject } from '@angular/core/testing';

import { NumberInWordsConverterService } from './numberinwords-converter.service';

describe('NumberInWordsConverterService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [NumberInWordsConverterService]
    });
  });

  it('should be created', inject([NumberInWordsConverterService], (service: NumberInWordsConverterService) => {
    expect(service).toBeTruthy();
  }));
});
