# -*- coding: utf-8 -*-
#-------------------------------------------------------------------------------
# Name:        module1
# Purpose:
#
# Author:      Администратор
#
# Created:     23.12.2019
# Copyright:   (c) Администратор 2019
# Licence:     <your licence>
#-------------------------------------------------------------------------------

import time
import requests
import random
from bs4 import BeautifulSoup
import io
import json
import os


src_name = 'links.txt'
destname = "videos.txt"
set_name = 'parse.config'
cook_id = raw_input(u'Введите id аккаунта, если он отличается от дефолтного либо жмите Enter: ') or 'OA1y'

def ReadData(_file_name):
    """
    Читает исходные данные из файла
    """
    if os.path.exists(_file_name):

        with open(_file_name, "r") as read_file:

            curses = json.load(read_file)                                       # curses = json.load(_file_name)
        return curses

    else:
        _file_name = raw_input('Not exists. Input valid name or full pathname for source file:')

        return ReadData(_file_name)


def get_headers(last_header = None):

    _cookies = { 'PHPSESSID':  '',                                              # 3pm4u3n96cjninad8h89ml0j35
                "id" : cook_id,
                'hash':'',                                                      # e719eb967ada6c3a91bbedc931071cd7   M1Y%3D
    }

    if os.path.exists(set_name) and last_header == None:
        with open(set_name, "r") as _config:
            _cookies['PHPSESSID'] = _config.readline()
            _cookies['hash'] = _config.readline()
    else:
        default_sess =  '(default = %s)'%last_header['PHPSESSID'] if last_header else ''
        mess = 'Input valid PHPSESSID%s:'%default_sess
        sess = raw_input(mess)
        _cookies['PHPSESSID'] = sess or (last_header['PHPSESSID'] if last_header else '')

        default_hash =  '(default = %s)'%last_header['hash'] if last_header else ''
        _hash = raw_input('Input valid hash%s:'%default_hash)
        _cookies['hash'] = _hash or (last_header['hash'] if last_header else '')



        with open(set_name, "w") as _config:
            _config.writelines([_cookies['PHPSESSID'] + '\n', _cookies['hash']])


    _headers = {
        "Accept":"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8",
        "Accept-Encoding":"gzip, deflate, br",
        "Accept-Language":"ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4",
        #"Cache-Control":"max-age=0",
        "Connection":"keep-alive",
        "Host":"skyschool.emdesell.ru",
        "Referer":"https://skyschool.emdesell.ru/student",
        "Upgrade-Insecure-Requests":"1",
        "User-Agent":"Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 UBrowser/7.0.185.1002 Safari/537.36",
    }

    return (_cookies, _headers)

def v_stuff(_curses, cookies, headers):

    page = None
    flag = False

    _videos = {}

    for k,v in _curses.iteritems():

        _videos[k] = []
        print k + ':'

        for less in v:
            headers['Referer'] = less

            print 'started ' + less

            page = None

            try:
                page = requests.get(less, cookies=cookies, headers=headers)
                if len(page.cookies) == 0:
                    print 'response error. Check request headers'

                    return None
        ##                break
            except:
                print 'Invaled cookies. Change headers'

                return None

            bf = BeautifulSoup(page.text, "html5lib")                               # html.parser | lxml
            video_frame = bf.find('iframe')

            if video_frame is None:
                print 'Skip item as void and waiting for 3 sec: '
                time.sleep(3)

                continue

            url = 'https:' + video_frame['src']
                                                                                    #po = json.loads(data_frame)
            _videos[k].append(url)                                                   # po['sources'][0]['src']
            print  'completed ' + less

            w = round(random.uniform(0.4, 4),2)
            print 'Next wait ' + str(w) + ' sec:'

            time.sleep(w)

            #break

    return _videos










# main_code:

curses = ReadData(src_name)

cookies, headers = get_headers()

videos = v_stuff(curses, cookies, headers)

while videos == None:
    cookies, headers = get_headers(cookies)
    videos = v_stuff(curses, cookies, headers)







my_file = io.open(destname, 'w', encoding='utf8')
my_file.write(videos.__str__().decode('unicode_escape'))
my_file.close()

import os
os.system(destname)
