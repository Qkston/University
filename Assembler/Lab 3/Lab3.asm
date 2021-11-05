_STACK segment para stack
    db 1024 dup(?)
_STACK ends

_DATA segment
    N dw ?
    M dw ?
    K dw ?

    msg1 db 'A = ','$'
    msg2 db 'B = ','$'
    msg3 db 'Sign: ','$'
    msg4 db 10,13,'Result: ','$'
_DATA ends

_TEXT segment
    assume cs:_TEXT, ds:_DATA, ss:_STACK
   main proc
        mov ax, _DATA
        mov ds, ax

        mov ah,09h
        lea dx,msg1
        int 21h

        xor cx,cx
        xor ah,ah

        mov ah,01h
        int 21h
        sub al,30h
        mov ah,0
        mov bx,10
        mov cx,ax

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
        mov N,cx
        mov ax,N
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
        mov M,cx
        mov ax,M
        mov cx,10

        xor cx,cx

        mov ah,09h
        lea dx,msg3
        int 21h

sign1:
        mov ah,01h
        int 21h
        cmp al,'+'
        je add1
        cmp al,'-'
        je sub1

add1:
        mov ax, N                   ; ax=N
        add ax, M                   ; ax=N+M
        mov K, ax                   ; K=ax, K=N+M

        mov ah,09h
        lea dx,msg4
        int 21h
        
        mov ax,K
        
        jmp test_result

sub1:
        mov ax, N                   ; ax=N
        sub ax, M                   ; ax=N-M
        mov K, ax                   ; K=ax, K=N-M

        mov ah,09h
        lea dx,msg4
        int 21h

        mov ax,K
        
        jmp test_result

test_result:
        test ax,ax
        jns if_plus
        
        mov cx,ax
        mov ah,02h
        
        mov dl,'-'
        int 21h
        mov ax,cx
        neg ax

if_plus:
        xor cx,cx
        xor dx,dx
        
        push -1  
        mov cx,10

init:
        xor dx,dx
        mov cx,10
        div cx
        push dx
        cmp ax,0
        jne init
        mov ah,2h

digit:
        pop dx
        cmp dx,-1
        je exit
        add dl,'0'
        int 21h
        jmp digit

exit:
        mov ax, 4C00h
        int 21h
        
        main endp
    _TEXT ends
end main