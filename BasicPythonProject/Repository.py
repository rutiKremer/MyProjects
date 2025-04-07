# -*- coding: utf-8 -*-
import os

from FolderAndFiles import *
from Version import Version
import datetime
import pickle

class Repository:

    def __init__(self,project_path):
        self.version_list = []
        self.project_path = project_path

#####################################

    def repository_init(self):
        create_folder(os.path.join(self.project_path, ".wit"))
        create_folder(os.path.join(self.project_path,".wit","committed copy"))
        create_folder(os.path.join(self.project_path, ".wit", "staging copy"))
        create_folder(os.path.join(self.project_path, ".wit", "current version"))
        current_version_path = os.path.join(self.project_path, ".wit", "current version")
        if(os.path.exists(current_version_path)):
            shutil.rmtree(current_version_path)
        copy_folder(self.project_path, current_version_path)
        delete_folder(os.path.join(current_version_path, ".wit"))

###########################################################
    def repository_add(self,source_file_path):
        copy_file(source_file_path,self.project_path+"\.wit\staging copy")

##########################################

    def repository_commit(self,messege):
        current_version_path = os.path.join(self.project_path, ".wit", "current version")
        if (os.path.exists(current_version_path)):
            shutil.rmtree(current_version_path)
        copy_folder(self.project_path, current_version_path)
        #delete_folder(os.path.join(current_version_path, ".wit"))
        v = Version(len(self.version_list)+1,datetime.date.today(),messege)
        self.version_list.append(v)
        create_folder(os.path.join(self.project_path,".wit","committed copy",str(v.id)))
        copy_folder(os.path.join(self.project_path,".wit","staging copy"),os.path.join(self.project_path,".wit","committed copy",str(v.id)))
        copy_folder(os.path.join(self.project_path, ".wit", "current version"), os.path.join(self.project_path, ".wit", "committed copy", str(v.id)))
        empty_folder(os.path.join(self.project_path,".wit","staging copy"))
        save_obj_to_file(self,r"C:\Users\user1\Desktop\proj\.wit\proj_wit.txt")


##########################################
    def repository_log(self):
        string = ""
        for v in self.version_list:
            string += str(v.id) + "-" + str(v.date) + "-" + v.messege + "\n"
        return string

    ##########################################

    def repository_status(self):
        return len(os.listdir(os.path.join(self.project_path,".wit","staging copy"))) > 0

    ########################################
    def repository_checkout(self, id_version):
        if (id_version >= 0 and id_version < len(self.version_list)):
             empty_folder(os.path.join(self.project_path,".wit","current version"))
             copy_folder(os.path.join(self.project_path, ".wit", "committed copy", str(id_version)),
                        os.path.join(self.project_path, ".wit", "current version"))
             # מחיקת כל הקבצים של הפרוייקט הנוכחי מתקיית הפרוייקט למעט התיקייה .wit
             for item in os.listdir(self.project_path):
                item_path = os.path.join(self.project_path, item)
                if item != ".wit":
                    os.unlink(item_path)
             copy_folder(os.path.join(self.project_path,".wit","committed copy",str(id_version)),self.project_path)
