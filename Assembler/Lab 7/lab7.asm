LOCALS
.model small
.stack 100h
.data
    CrLf db 0Dh, 0Ah,"$";$&#39;
    A dw ?
    B dw ?
    Accuracy dw 2 ;????????? ?????????? ?????? ????? ????
    
    msg1 db 'A = ','$'
    msg2 db 'B = ','$'
    msg3 db 'Result: ','$'
    msg4 db 10,13,'If you want to repeat enter "n": ','$'
    msg5 db 10,13,'Program is ending','$'
    
    nxtline db 10,'$
.code
main proc
    mov ax, @data
    mov ds, ax
    
    mov ah,09h
    lea dx,msg1
    int 21h

first:
    mov ah,01h
    int 21h
    cmp al,0dh
    je end_first
    sub al,30h
    cbw
    xchg ax,cx

    mul bx
    add cx,ax
    jmp first

end_first:
    mov A,cx
    mov ax,A
    mov cx,10

    xor cx,cx

    mov ah,09h
    lea dx,msg2
    int 21h

second:
    mov ah,01h
    int 21h
    cmp al,0dh
    je end_second
    sub al,30h
    cbw
    xchg ax,cx

    mul bx
    add cx,ax
    jmp second

end_second:
    mov B,cx
    mov ax,B
    mov cx,10

    xor cx,cx

    mov ah,09h
    lea dx,msg3
    int 21h
    
diver:
    ;??????? A ?? B ? ????????? ????? ???????
    mov ax, [A] ;dx:ax = A
    mov dx, 0
    mov bx, [B] ;bx = B
    idiv bx ;ax = A / B, dx = A % B
    call Show_AX
    ;????? ????
    push dx
    mov ah, 02h
    mov dl, ",";,&#39;
    int 21h
    pop dx
    ;????? ????????? ?????????? ?????? ??????????? ?????
    mov si, 10
    mov cx, [Accuracy] ;????????? ?????? ????? ????
    
For:
    mov ax, dx
    mul si
    div bx
    call Show_AX
    loop For

repeat_1:
    mov ah,09h
    lea dx,nxtline
    int 21h
    
    mov ah,09h
    lea dx,msg4
    int 21h

entering:    
    mov ah,01h
    int 21h
    cmp al,"n"
    je check
    sub al,30h
    cbw
    xchg ax,cx

    mul bx
    add cx,ax
    jmp ending

check:
    mov ah,09h
    lea dx,nxtline
    int 21h
    
    jmp main

ending:
    mov ah,09h
    lea dx,msg5
    int 21h

    mov ah, 09h
    lea dx, [CrLf]
    int 21h
    mov ax, 4C00h
    int 21h
main endp

; ???????? ??? ??????? 16-???????? ????? ? ???????? AX ?? ?????
; ?????? ????:
; ax - ????? ??? ????????????
Show_AX proc
    push ax
    push bx
    push cx
    push dx
    push di
    mov cx, 10
    xor di, di ; di ? ????????? ???? ? ?????
Conv:
    xor dx, dx
    div cx ; dl = num mod 10
    add dl, "0";0&#39; ; ??????? ? ?????????? ??????
    inc di
    push dx ; ????????? ? ????

    xor ax, ax
    jnz Conv
    ; ???????? ? ????? ?? ?????
Show: 
    pop dx ; dl = ????????? ??????, ?? ??????????
    mov ah, 2 ; ah - ??????? ?????? ??????? ?? ?????
    int 21h
    dec di ; ?????????? ???? di&lt;&gt;0
    jnz Show
    pop di
    pop dx
    pop cx
    pop bx
    pop ax
    ret
Show_AX endp
end main