/*
 * Created by SharpDevelop.
 * User: CarlSkeel
 * Date: 10/2/2014
 * Time: 1:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ConvertToPigCSharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		/// <summary>
		/// Uses array passed in from method pigSentence
		/// </summary>
		/// <param name="word">Passed in from method pigSentence</param>
		/// <returns>Returns string to the pigSentence method after conversion.</returns>
		public string pigWord(string word)
		{
	    	string wordP = "";
	    	
	    	wordP = word.Substring(1) + word[0] + "ay";
	    	//or word[0] can be word.Substring(0, 1)
	    	
	    	return wordP;
		}
		
		/// <summary>
		/// Function to split the phrase words and uses 
		/// pigWord Method and then puts string back together.
		/// </summary>
		/// <param name="sentence">passes in the phrase from the input box from the user</param>
		/// <returns>returns the phrase in pig latin after use of pigWord method.</returns>
		public string pigSentence(string sentence)
		{
			string pigS = "";
		    string pigW = "";
		    
		    string [] wsplit = sentence.Split(new char [] {' ', ',', '.', ':', '\t', '!', '?' });
		    
		    foreach (string word in wsplit)
		    {
		        pigW = pigWord(word);
		        pigS = pigS + pigW + " ";		    
		    }
		    return pigS;
		}
		
		
		
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.convertBtn1 = new System.Windows.Forms.Button();
			this.OutputBox1 = new System.Windows.Forms.TextBox();
			this.clearBtn1 = new System.Windows.Forms.Button();
			this.closeBtn1 = new System.Windows.Forms.Button();
			this.InputBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// convertBtn1
			// 
			this.convertBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.convertBtn1.Location = new System.Drawing.Point(190, 12);
			this.convertBtn1.Name = "convertBtn1";
			this.convertBtn1.Size = new System.Drawing.Size(83, 68);
			this.convertBtn1.TabIndex = 3;
			this.convertBtn1.Text = "Convert To Pig Latin";
			this.convertBtn1.UseVisualStyleBackColor = false;
			this.convertBtn1.Click += new System.EventHandler(this.ConvertBtn1Click);
			// 
			// OutputBox1
			// 
			this.OutputBox1.AcceptsReturn = true;
			this.OutputBox1.Location = new System.Drawing.Point(279, 12);
			this.OutputBox1.Multiline = true;
			this.OutputBox1.Name = "OutputBox1";
			this.OutputBox1.ReadOnly = true;
			this.OutputBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.OutputBox1.Size = new System.Drawing.Size(172, 296);
			this.OutputBox1.TabIndex = 4;
			// 
			// clearBtn1
			// 
			this.clearBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.clearBtn1.Location = new System.Drawing.Point(190, 86);
			this.clearBtn1.Name = "clearBtn1";
			this.clearBtn1.Size = new System.Drawing.Size(83, 68);
			this.clearBtn1.TabIndex = 5;
			this.clearBtn1.Text = "Clear";
			this.clearBtn1.UseVisualStyleBackColor = false;
			this.clearBtn1.Click += new System.EventHandler(this.ClearBtn1Click);
			// 
			// closeBtn1
			// 
			this.closeBtn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.closeBtn1.Location = new System.Drawing.Point(190, 240);
			this.closeBtn1.Name = "closeBtn1";
			this.closeBtn1.Size = new System.Drawing.Size(83, 68);
			this.closeBtn1.TabIndex = 6;
			this.closeBtn1.Text = "Close";
			this.closeBtn1.UseVisualStyleBackColor = false;
			this.closeBtn1.Click += new System.EventHandler(this.CloseBtn1Click);
			// 
			// InputBox1
			// 
			this.InputBox1.Location = new System.Drawing.Point(12, 12);
			this.InputBox1.Multiline = true;
			this.InputBox1.Name = "InputBox1";
			this.InputBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.InputBox1.Size = new System.Drawing.Size(172, 296);
			this.InputBox1.TabIndex = 7;
			this.InputBox1.Text = "Enter text to convert here.";
			this.InputBox1.Click += new System.EventHandler(this.InputBox1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(530, 345);
			this.Controls.Add(this.InputBox1);
			this.Controls.Add(this.closeBtn1);
			this.Controls.Add(this.clearBtn1);
			this.Controls.Add(this.OutputBox1);
			this.Controls.Add(this.convertBtn1);
			this.Name = "MainForm";
			this.Text = "ConvertToPigCSharp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox InputBox1;
		private System.Windows.Forms.Button closeBtn1;
		private System.Windows.Forms.Button clearBtn1;
		private System.Windows.Forms.TextBox OutputBox1;
		private System.Windows.Forms.Button convertBtn1;
		
		
		void InputBox1Click(object sender, System.EventArgs e)
		{
			this.InputBox1.Text = "";
			this.OutputBox1.Text = "<--- Enter a new phrase to convert.";		
		}
		
		
		
		/// <summary>
		/// Convert Btn Event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ConvertBtn1Click(object sender, System.EventArgs e)
		{
			if(this.InputBox1.Text != null){
			var input1 = this.InputBox1.Text;
			this.OutputBox1.Text = "Your phrase in pig latin is: \n" + pigSentence(input1);
			}else
			{
				this.InputBox1.Text = "You must enter a sentence to convert here!";
			}
		}
		
		/// <summary>
		/// Clear Button Event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ClearBtn1Click(object sender, System.EventArgs e)
		{
			this.InputBox1.Text = "";
			this.OutputBox1.Text = "<--- Enter a new phrase to convert.";
		}
		
		/// <summary>
		/// Close Button Event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void CloseBtn1Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
				
		
	}
}
