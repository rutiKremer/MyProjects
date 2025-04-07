import click
import os
from Repository import *
from FolderAndFiles import *

@click.group()
def cli():
    """ Wit Version Control CLI """
    pass


@click.command()
def init():
    path = os.getcwd()
    wit_dir = os.path.join(path, ".wit")
    if not os.path.exists(wit_dir):
        wit = Repository(path)
        wit.repository_init()
        save_obj_to_file(wit, os.path.join(path, ".wit\wit object"))

@click.command()
def add():
    file_path = os.getcwd()
    wit = load_obj_from_file(os.path.dirname(file_path)+"\.wit\wit object")
    wit.repository_add(file_path)

@click.command()
@click.argument('message')
def commit(message):
    path = os.getcwd()
    wit = load_obj_from_file(path+"\.wit\wit object")
    wit.repository_commite(message)
    save_obj_to_file(wit, os.path.join(path, ".wit\wit object"))


@click.command()
def log():
    path = os.getcwd()
    wit = load_obj_from_file(path + "\.wit\wit object")
    click.echo(wit.repository_log())

@click.command()
def status():
    path = os.getcwd()
    wit = load_obj_from_file(path + "\.wit\wit object")
    click.echo(wit.repository_status())

@click.command()
@click.argument('id_version')
def checkout(id_version):
    path = os.getcwd()
    wit = load_obj_from_file(path + "\.wit\wit object")
    wit.repository_checkout(int(id_version))


cli.add_command(init)
cli.add_command(add)
cli.add_command(commit)
cli.add_command(log)
cli.add_command(status)
cli.add_command(checkout)

if __name__ == '__main__':
    cli()

