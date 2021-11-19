_STACK segment para stack
    db 1024 dup(?)
_STACK ends

_DATA segment
    _A dw 2
    _B dw 8
    _C dw 4
    _D dw 3

    _x dw ?
    _y dw ?
    Res dw 0
    
    msg1 db 'Result: ','$'
_DATA ends

_TEXT segment
    assume cs:_TEXT, ds:_DATA, ss:_STACK
   main proc
        mov ax, _DATA
        mov ds, ax

        xor cx,cx
        xor ah,ah
        
        mov ah,09h
        lea dx,msg1
        int 21h


solve:
        mov dx,0
        mov bx,0
        mov cx,0
        
        mov ax,_B
        mov cx,_C
        div cx
        mov _x,ax
        
        mov dx,0
        
        mov ax,_A
        mul _D
        mov _y,ax
        
        sub ax,_x
        
        mov Res,ax
        mov ax,Res
        

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