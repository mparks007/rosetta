
if __name__ == "__main__":
    print('Python Data Types\n')

    # -------------
    # Numeric Types
    # -------------
    print('***Numeric Types***\n')
    # int, float, complex

    someInt = 10
    print(f'Type(int): someInt:{someInt}, type(someInt):{type(someInt)}')

    someFloat = 2.5
    print(
        f'Type(float): someFloat:{someFloat}, type(someFloat):{type(someFloat)}')

    intFromFloat = int(someFloat)  # will drop the decimal part
    print(
        f'Type(int): intFromFloat:{intFromFloat}, type(intFromFloat):{type(intFromFloat)}')

    floatAsExponential = 3e4
    print(
        f'Type(float): floatAsExponential:{floatAsExponential}, type(floatAsExponential):{type(floatAsExponential)}')

    floatAsNegExponential = 5e-2
    print(
        f'Type(float): floatAsNegExponential:{floatAsNegExponential}, type(floatAsNegExponential):{type(floatAsNegExponential)}')

    floatFromInt = float(someInt)
    print(
        f'Type(float): floatFromInt:{floatFromInt}, type(floatFromInt):{type(floatFromInt)}')

    someComplex = 2+6j  # number before j as the imaginary part
    print(
        f'Type(complex): someComplex:{someComplex}, type(someComplex):{type(someComplex)}')

    # optional second value (5 here) as imaginary part
    complexFromFunc = complex(3, 5)
    print(
        f'Type(complex): complexFromFunc:{complexFromFunc}, type(complexFromFunc):{type(complexFromFunc)}')

    print("Binary: 0b1101010:", 0b1101010)
    print("Hex: 0xAF:", 0xAF)
    print("Hex/Binary: 0xFB + 0b11:", 0xFB + 0b11)
    print("Octal: 0o13:", 0o13)

    # ------------
    # Boolean Type
    # ------------
    print('\n***Boolean Type***\n')
    # bool

    someBool = True
    boolFromNotOfBool = not someBool
    boolFromOr = True or False
    print(
        f'Type(bool): someBool:{someBool}, boolFromNotOfBool:{boolFromNotOfBool}, boolFromOr:{boolFromOr}')

    # ---------
    # Text Type
    # ---------
    print('\n***Text Type***\n')
    # str (aka string)
    # https://www.programiz.com/python-programming/string

    str0 = ''  # or ""
    str1 = 'Hello'  # or "Hello"
    str2 = 'Here are "double-quotes" in a string'  # if want to have " in the string
    str3 = "Let's try apostrophe"  # if want to have ' in the string
    print(
        f'Type(str): str0:{str0}, str1:{str1}, str2:{str2}, str3:{str3}, type(str3):{type(str3)}')

    strWrap0 = """This is
    a multi-line string"""
    strWrap1 = '''This is
    too'''
    print(f'Type(str): strWrap0:{strWrap0}, strWrap1:{strWrap1}')

    print("Hello * 3 =", "Hello" * 3)

    someText = "SomeText"
    print('someText =', someText)
    print('someText[0] =', someText[0])  # first character
    print('someText[-1] =', someText[-1])  # last character
    # last character
    print('someText[len(someText) - 1] =', someText[len(someText) - 1])
    # slicing 2nd character to end
    print('Slicing: someText[1:] =', someText[1:])
    # slicing 2nd to 5th character
    print('Slicing: someText[1:5] =', someText[1:5])
    # slicing uyp to 5th character
    print('Slicing: someText[:5] =', someText[:5])
    # slicing 6th to 2nd last character
    print('Slicing: someText[5:-2] =', someText[5:-2])

    # ------------
    # Mapping Type
    # ------------
    print('\n***Mapping Type***\n')
    # dict (aka dictionary)
    # https://www.programiz.com/python-programming/dictionary

    dict0 = {}
    bookMeta = {  # try with immediate info
        "title": "Dune",
        "author": "Frank Herbert",
        "pages": 300,
        "cost": 7.99
    }
    print(
        f'Type(dict): dict0:{dict0}, bookMeta:{bookMeta}',)

    licenseFinds = {  # try as empty start, then add stuff after
    }
    licenseFinds["TX Tags Seen"] = 4
    licenseFinds["OK Tags Seen"] = 3
    licenseFinds["TX Tags Seen"] += 1
    print(
        f'Type(dict): licenseFinds:{licenseFinds}, "KS Tags Seen":{licenseFinds.get("KS Tags Seen")}',)  # licenseFinds["KS Tags Seen"] throws since not found. ".get" doesn't throw

    # ---------
    # Set Types
    # ---------
    print('\n***Set Types***\n')
    # set (dupes auto-removed, nondeterministic order, only immutables)
    # https://www.programiz.com/python-programming/set

    emptySet = set()
    print(f"Type(set): emptySet:{emptySet}")

    ctorViaList = set(["car", "truck", "van"])
    print(f"Type(set): ctorViaList:{ctorViaList}")

    homes = {
        "Small": "Cheap",
        "Medium": "Affordable",
        "Large": "BigLoan"
    }
    homeSizes = set(homes)  # source is dict keys, or can do: homes.keys()
    print(f"Type(set): homeSizes:{homeSizes}")
    homeCosts = set(homes.values())  # source is dict values
    print(f"Type(set): homeCosts:{homeCosts}")

    pets = {"dog", "cat", "hamster", "dog"}
    print(f"Type(set): pets:{pets}")
    pets.add("fish")  # add a single element
    print(f"Type(set): pets:{pets}")
    # add a list, including dupe dog to prove it doesn't dupe
    pets.update(["dog", "turtle", "lizard"])
    print(f"Type(set): pets:{pets}")
    # or can use .remove (but remove will throw key error if not found)
    pets.discard("lizard")
    print(f"Type(set): pets:{pets}")
    print('Type(set): "chicken" in pets: ' + str("chicken" in pets))
    pets.clear()
    print(f"Type(set): pets:{pets}")

    domesticAnimals = {"dog", "cat", "elephant"}
    wildAnimals = {"lion", "tiger", "elephant"}
    # or with pipe: = domesticAnimals | wildAnimals
    unionOfAnimals = domesticAnimals.union(wildAnimals)
    print(f"Type(set:union): unionOfAnimals:{unionOfAnimals}")
    intersectionOfAnimals = domesticAnimals.intersection(
        wildAnimals)  # or with 'and': = domesticAnimals & wildAnimals
    print(f"Type(set:union): intersectionOfAnimals:{intersectionOfAnimals}")

    # frozenset (immutable version of set)
    # https://www.programiz.com/python-programming/methods/built-in/frozenset

    emptyFrozenset = frozenset()
    print(f"Type(frozenset): emptyFrozenset:{emptyFrozenset}")

    ctorViaList1 = frozenset(["car", "truck", "van"])
    print(f"Type(frozenset): ctorViaList1:{ctorViaList1}")
    homes = {
        "Small": "Cheap",
        "Medium": "Affordable",
        "Large": "BigLoan"
    }
    # source is dict keys, or can do: homes.keys()
    homeSizes = frozenset(homes)
    print(f"Type(frozenset): homeSizes:{homeSizes}")
    homeCosts = frozenset(homes.values())  # source is dict values
    print(f"Type(frozenset): homeCosts:{homeCosts}")

    pets = frozenset(["dog", "cat", "hamster", "dog"])
    print(f"Type(frozenset): pets:{pets}")
    myPets = frozenset(["dog", "cat"])
    print(f"Type(frozenset): myPets:{myPets}")
    intersectionofPets = pets & myPets  # or: = pets.intersection(myPets)
    print(
        f"Type(frozenset:intersection): intersectionofPets:{intersectionofPets}")

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

    # struct (not really a Python thing)

    # class (see class.py)

    # "interface" (not really a thing, see interface.py for the "abstract class" that acts like an interface)

    # delegate (how would this work? see delegate.py)

    # -------------
    # Generic Types
    # -------------
    print('\n***Generic Types***\n\n')

    # https: // medium.com/@steveYeah/using-generics-in-python-99010e5056eb

    print('\nDone!')
