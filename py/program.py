
if __name__ == "__main__":
    print('Python Data Types\n')

    # -------------
    # Numeric Types
    # -------------
    print('***Numeric Types***\n')
    # int, float, complex

    i0 = 10
    f0 = 2.5
    i1 = int(f0)
    f1 = 3e4
    f2 = 5e-2
    f3 = float(i0)
    c = 2+6j
    print(f'Type(int): i0:{i0}, type(i0):{type(i0)}')
    print(f'Type(float): f0:{f0}, type(f0):{type(f0)}')
    print(f'Type(int): i1:{i1}, type(i1):{type(i1)}')
    print(f'Type(float): f1:{f1}, type(f1):{type(f1)}')
    print(f'Type(float): f2:{f2}, type(f2):{type(f2)}')
    print(f'Type(float): f3:{f3}, type(f3):{type(f3)}')
    print(f'Type(complex): c:{c}, type(c):{type(c)}')

    # ------------
    # Boolean Type
    # ------------
    print('\n***Boolean Type***\n')
    # bool

    b0 = True
    b1 = not b0
    b2 = True or False
    print(f'Type(bool): b0:{b0}, b1:{b1}, b2:{b2}')

    # ---------
    # Text Type
    # ---------
    print('\n***Text Type***\n')
    # str

    s0 = ''  # or ""
    s1 = 'Hello'  # or "Hello"
    s2 = 'Here are "double-quotes" in a string'
    s3 = "Let's try apostrophe"
    print(
        f'Type(str): s0:{s0}, s1:{s1}, s2:{s2}, s3:{s3}, type(s3):{type(s3)}')
    s4 = """This is
    a multi-line string"""
    s5 = '''This is
    too'''
    print(f'Type(str): s4:{s4}, s5:{s5}')

    # ------------
    # Mapping Type
    # ------------
    print('\n***Mapping Type***\n')
    # dict

    d0 = {}
    d1 = {
        "title": "Dune",
        "author": "Frank Herbert",
        "pages": 300,
        "cost": 7.99
    }
    d2 = {
    }
    d2["TX Tags Seen"] = 4
    d2["OK Tags Seen"] = 3
    d2["TX Tags Seen"] += 1
    print(
        f'Type(dict): d0:{d0}, d1:{d1}, d2:{d2}, "KS Tags Seen":{d2.get("KS Tags Seen")}',)

    # ---------
    # Set Types
    # ---------
    print('\n***Set Types***\n')
    # set, frozenset

    # --------------
    # Sequence Types
    # --------------
    print('\n***Sequence Types***\n')
    # range, tuple, list

    # ------------
    # Binary Types
    # ------------
    print('\n***Binary Types***\n')
    # bytes, bytearray, memoryview

    # ------------
    # Custom Types
    # ------------
    print('\n***Custom Types***\n\n')

    # enumeration (uses a library, see enum.py)
    # https: // docs.python.org/3/library/enum.html

    # struct (not really a Python thing like many other languaes)

    # class (see class.py)

    # "interface" (not really a thing, see interface.py for the "abstract class" that acts like an interface)

    # delegate (how would this work? see delegate.py)

    # -------------
    # Generic Types
    # -------------
    print('\n***Generic Types***\n\n')

    # https: // medium.com/@steveYeah/using-generics-in-python-99010e5056eb

    print('\nDone!')
