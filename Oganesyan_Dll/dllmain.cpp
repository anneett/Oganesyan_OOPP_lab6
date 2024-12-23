// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"
#include "Library.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

struct Book_struct {
    char title[256];
    char author[256];
    int release_year;
    char publishing_house[256];
    bool in_stock;
    double rating;
    char link[256];
};

Library library;

extern "C" {

    __declspec(dllexport) void __stdcall SaveLibrary(const char* filename) {
        library.SaveToFile(filename);
    }

    __declspec(dllexport) void __stdcall LoadLibraryBooks(const char* filename) {
        library.LoadFromFile(filename);
    }

    __declspec(dllexport) void __stdcall SaveBooks(const char* filename) {
        library.SaveToFile(filename);
    }

    __declspec(dllexport) int __stdcall GetLibrarySize() {
        return library.GetSize();
    }

    __declspec(dllexport) void Clear() {
        library.Clear();
    }

    _declspec(dllexport) void __stdcall UpdateBook(Book_struct& book_struct, int id) {
        if (id < 0 || id >= library.GetSize()) return;

        auto book = library.get(id);

        book->setTitle(book_struct.title);
        book->setAuthor(book_struct.author);
        book->setRelease_Year(book_struct.release_year);
        book->setPublishing_House(book_struct.publishing_house);
        book->setIn_Stock(book_struct.in_stock);
        book->setRating(book_struct.rating);

        auto eBook = dynamic_pointer_cast<EBook>(book);
        if (eBook) {
            eBook->setLink(book_struct.link);
        }
    }

    __declspec(dllexport) void __stdcall AddBook(int param) {
        if (param == 0) {
            auto book = make_shared<Book>();
            book->setTitle("");
            book->setAuthor("");
            book->setRelease_Year(0);
            book->setPublishing_House("");
            book->setIn_Stock(false);
            book->setRating(0.0);
            library.AddBook(book);
        }
        else {
            auto ebook = make_shared<EBook>();

            ebook->setTitle("");
            ebook->setAuthor("");
            ebook->setRelease_Year(0);
            ebook->setPublishing_House("");
            ebook->setIn_Stock(false);
            ebook->setRating(0.0);
            ebook->setLink("");
            library.AddBook(ebook);
        }
    }

    __declspec(dllexport) void GetBook(Book_struct& book_data, int id) {

        if (id < 0 || id >= library.GetSize()) return;
        auto book = library.get(id);

        strcpy_s(book_data.title, book->getTitle().c_str());
        strcpy_s(book_data.author, book->getAuthor().c_str());
        book_data.release_year = book->getRelease_Year();
        strcpy_s(book_data.publishing_house, book->getPublishing_House().c_str());
        book_data.in_stock = book->getIn_Stock();
        book_data.rating = book->getRating();
        
        auto eBook = dynamic_pointer_cast<EBook>(book);
        if (eBook) {
            strcpy_s(book_data.link, eBook->getLink().c_str());
        }
    }

    __declspec(dllexport) int GetSize() {
        return library.GetSize();
    }

    __declspec(dllexport) void DeleteBook(int id) {
        library.Delete(id);
    }
}