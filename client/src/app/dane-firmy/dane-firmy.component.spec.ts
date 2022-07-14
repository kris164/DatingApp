import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DaneFirmyComponent } from './dane-firmy.component';

describe('DaneFirmyComponent', () => {
  let component: DaneFirmyComponent;
  let fixture: ComponentFixture<DaneFirmyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DaneFirmyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DaneFirmyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
