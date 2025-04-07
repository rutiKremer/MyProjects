from Repository import *

# r = Repository(r"C:\Users\user1\Desktop\proj")
# r.repository_init()

r= load_obj_from_file(r"C:\Users\user1\Desktop\proj\.wit\proj_wit.txt")
#r.repository_add(r"C:\Users\user1\Desktop\proj\b.txt")
#r.repository_commit("my first version")
r.repository_checkout(1)
save_obj_to_file(r,r"C:\Users\user1\Desktop\proj\.wit\proj_wit.txt")
