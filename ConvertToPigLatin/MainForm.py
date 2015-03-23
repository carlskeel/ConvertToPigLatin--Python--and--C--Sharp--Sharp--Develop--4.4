
import re

import System.Drawing
import System.Windows.Forms

from System.Drawing import *
from System.Windows.Forms import *

def pigWord(word):
    	wordP = word[1:] + word[0] + "ay"
    	return wordP

def pigSentence(sentence):
	    pigS = ""
	    words = re.findall(r"[a-zA-Z]+", sentence)
	    #words = sentence.split()
	    for word in words:
	        pigW = pigWord(word)
	        pigS = pigS + pigW + " "
	    return pigS



class MainForm(Form):
	def __init__(self):
		self.InitializeComponent()
	
	def InitializeComponent(self):
		resources = System.Resources.ResourceManager("ConvertToPigLatin.MainForm", System.Reflection.Assembly.GetEntryAssembly())
		self._InputBox1 = System.Windows.Forms.TextBox()
		self._OutputBox1 = System.Windows.Forms.TextBox()
		self._convertBtn1 = System.Windows.Forms.Button()
		self._closeBtn1 = System.Windows.Forms.Button()
		self._clearBtn1 = System.Windows.Forms.Button()
		self.SuspendLayout()
		# 
		# InputBox1
		# 
		self._InputBox1.Location = System.Drawing.Point(12, 12)
		self._InputBox1.Multiline = True
		self._InputBox1.Name = "InputBox1"
		self._InputBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		self._InputBox1.Size = System.Drawing.Size(172, 296)
		self._InputBox1.TabIndex = 0
		self._InputBox1.Text = "Enter text to convert here."
		self._InputBox1.Click += self.InputBox1Click
		# 
		# OutputBox1
		# 
		self._OutputBox1.AcceptsReturn = True
		self._OutputBox1.Location = System.Drawing.Point(279, 12)
		self._OutputBox1.Multiline = True
		self._OutputBox1.Name = "OutputBox1"
		self._OutputBox1.ReadOnly = True
		self._OutputBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		self._OutputBox1.Size = System.Drawing.Size(172, 296)
		self._OutputBox1.TabIndex = 1
		# 
		# convertBtn1
		# 
		self._convertBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		self._convertBtn1.Location = System.Drawing.Point(190, 12)
		self._convertBtn1.Name = "convertBtn1"
		self._convertBtn1.Size = System.Drawing.Size(83, 68)
		self._convertBtn1.TabIndex = 2
		self._convertBtn1.Text = "Convert To Pig Latin"
		self._convertBtn1.UseVisualStyleBackColor = False
		self._convertBtn1.Click += self.ConvertBtn1Click
		# 
		# closeBtn1
		# 
		self._closeBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		self._closeBtn1.Location = System.Drawing.Point(190, 240)
		self._closeBtn1.Name = "closeBtn1"
		self._closeBtn1.Size = System.Drawing.Size(83, 68)
		self._closeBtn1.TabIndex = 3
		self._closeBtn1.Text = "Close"
		self._closeBtn1.UseVisualStyleBackColor = False
		self._closeBtn1.Click += self.CloseBtn1Click
		# 
		# clearBtn1
		# 
		self._clearBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		self._clearBtn1.Location = System.Drawing.Point(190, 86)
		self._clearBtn1.Name = "clearBtn1"
		self._clearBtn1.Size = System.Drawing.Size(83, 68)
		self._clearBtn1.TabIndex = 4
		self._clearBtn1.Text = "Clear"
		self._clearBtn1.UseVisualStyleBackColor = False
		self._clearBtn1.Click += self.ClearBtn1Click
		# 
		# MainForm
		# 
		self.BackColor = System.Drawing.SystemColors.ControlDark
		self.BackgroundImage = resources.GetObject("$this.BackgroundImage")
		self.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		self.ClientSize = System.Drawing.Size(621, 320)
		self.Controls.Add(self._clearBtn1)
		self.Controls.Add(self._closeBtn1)
		self.Controls.Add(self._convertBtn1)
		self.Controls.Add(self._OutputBox1)
		self.Controls.Add(self._InputBox1)
		self.Name = "MainForm"
		self.Text = "Convert To Pig Latin by Carl Skeel 2014"
		self.ResumeLayout(False)
		self.PerformLayout()

####test def for button	
#	def ConvertBtn1Click(self, sender, args):
#		self._OutputBox1.Text = "Convert button pressed"
	
	def ConvertBtn1Click(self, sender, args):
		input1 = self._InputBox1.Text
		self._OutputBox1.Text = "Your phrase in pig latin is: \n" + pigSentence(input1)
	

	def CloseBtn1Click(self, sender, args):
		try:
			self.Close()
		except Exception as ex:
			print ex	

	def InputBox1Click(self, sender, args):
		self._InputBox1.Text = ""	
		self._OutputBox1.Text = "<--- Enter a your phrase to convert.\t Then press the convert Button."

	def ClearBtn1Click(self, sender, args):
		self._InputBox1.Text = ""	
		self._OutputBox1.Text = "<--- Enter a new phrase to convert. \t Then press the convert Button."




