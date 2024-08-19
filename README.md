# VMTranslator

The VMTranslator is a simple program that translates VM code into Hack Assembly code.
The VM code is a simple stack-based language that is used in the Nand2Tetris course.
The Hack Assembly code is a simple assembly language that is used in the course.

## Usage

`VMTranslator <input file>` will read the input file and translate
the VM code into Hack Assembly code.
The output will be written to a file with the same name as the
input file, but with the extension `.asm`.
If the input file is a directory, the VMTranslator will translate
all the `.vm` files in the directory and write the output to a file
with the same name as the directory, but with the extension `.asm`.
