TITLE ????? ????????        ; ?????????
.MODEL SMALL
.STACK 200h
.DATA
Message DB 'Slynko Andrii, KS-19',13,10,'$';
.CODE
Start:
mov ax,@Data
mov ds,ax                   ; ?????????? ??????? DS ?????
                            ; ?????, ??? ??? ???????? ?? ??????? ?????
mov ah,9                    ; ??????? DOS ????? ?????
mov dx,OFFSET Message       ; ????? ?? ???????????? "HELLO!";
int 21h                     ; ??????? "HALLO!" ?? ?????
mov ah,4ch                  ; ??????? DOS ?????????? ????????
int 21h                     ; ????????? ????????
END Start