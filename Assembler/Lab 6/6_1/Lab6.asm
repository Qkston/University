_STACK segment para stack
    db 1024 dup(?)
_STACK ends

_DATA segment
    _A dw 8
    _B dw 3
    _C dw 9
    _D dw 1

    _x dw ?
    _y dw ?
    
    len equ 6
    
    temp dw 0
    
    msg1 db 'Result: ','$'
_DATA ends

_TEXT segment
    assume cs:_TEXT, ds:_DATA, ss:_STACK
   main proc
        mov ax, _DATA
        mov ds, ax

        mov cx,len
        xor ax,ax
        xor si,si
        
        mov ah,09h
        lea dx,msg1
        int 21h


solve:
        mov ax, _A
        mul _D
        mov _x, ax
                
        mov ax, _C
        mov bx, _B          
        div bl                   
        mov _y, ax 
                      
        mov ax, _x
        sub ax, _y 
        
        add _D,1
        add temp,ax 
        xor ax, ax               
  
        dec cx
        cmp cx,0    
        jne solve         
        
        mov ax, temp
        

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