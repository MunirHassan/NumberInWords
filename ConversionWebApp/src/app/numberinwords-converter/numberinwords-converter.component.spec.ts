import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NumberInWordsConverterComponent } from './numberinwords-converter.component';

describe('NumberInWordsConverterComponent', () => {
  let component: NumberInWordsConverterComponent;
  let fixture: ComponentFixture<NumberInWordsConverterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NumberInWordsConverterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NumberInWordsConverterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
