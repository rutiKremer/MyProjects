# -*- coding: utf-8 -*-
import os
import pickle
import shutil

###############################
def create_folder(path):
    #יצירת תיקייה
    if not os.path.exists(path):
        os.makedirs(path)
    else:
        print("exsist this folder")

###################################
def copy_file(source_path,destination_path):
    # העתקת קבצים מניתוב לניתוב חדש
    try:
        shutil.copy(source_path, destination_path)
    except Exception as e:
        print("error copy_file")

#################################
def get_absolute_path(name):
    #החזרת ניתוב קובץ\תיקייה ע"י קבלת שם הקובץ\התיקייה
    return os.path.abspath(name)

##################################
def copy_folder(source_dir, destination_dir):
    # בדוק אם המקור והיעד הם אותו תיק
    if os.path.abspath(source_dir) == os.path.abspath(destination_dir):
        print("מקור ויעד הם אותו תיק. העתקה בוטלה.")
        return

    if not os.path.exists(source_dir):
        print("שגיאה: מקור לא קיים - {source_dir}")
        return

    if os.path.exists(destination_dir):
        delete_folder(destination_dir)  # הנח ש-delete_folder פועלת כראוי

    def ignore_paths(src, names):
        # התעלם מתיקיות או קבצים בתיקיה ".wit"
        return [name for name in names if name == '.wit']

    try:
        shutil.copytree(source_dir, destination_dir, ignore=ignore_paths)
        print("ההעתקה מ-{source_dir} ל-{destination_dir} הושלמה בהצלחה.")
    except Exception as e:
        print("שגיאה בהעתקת תיקיה מ-{source_dir} ל-{destination_dir}: {e}")


##################################
def empty_folder(directory_path):
    # מחיקת כל התוכן מתיקייה קיימת
    try:
        items = os.listdir(directory_path)
        if not items:
            print("התיקייה ריקה.")
            return
        for item in items:
            item_path = os.path.join(directory_path, item)
            if os.path.isfile(item_path):
                os.remove(item_path)
            elif os.path.isdir(item_path):
                shutil.rmtree(item_path)
    except Exception as e:
        print("שגיאה בזמן ריקון התיקייה: {e}")


#################################
def delete_folder(folder_path):
    # מוחק את התיקיה וכל התוכן שבה
    if os.path.exists(folder_path):
        shutil.rmtree(folder_path)

#################################

def save_obj_to_file(obj, file_path):
    try:
        # שמירת אובייקט לקובץ
        with open(file_path, "wb") as file:
            pickle.dump(obj, file)
        print("success save_obj_to_file")
    except Exception as e:
        print("error save_obj_to_file")

#################################

def load_obj_from_file(file_path):
    try:
        # קריאת אובייקט מקובץ
        with open(file_path, 'rb') as file:
            obj = pickle.load(file)
        return obj
    except Exception as e:
        print("error load_obj_from_file")
