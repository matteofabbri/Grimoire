using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class SFTP_Transport_Protocol_DataType : INotifyPropertyChanged
	{
		private string sFTP_AddressField;

		private string directoryField;

		private string user_IDField;

		private object itemField;

		private bool use_Temp_FileField;

		private bool use_Temp_FileFieldSpecified;

		private decimal block_SizeField;

		private bool block_SizeFieldSpecified;

		private string block_Size_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string SFTP_Address
		{
			get
			{
				return this.sFTP_AddressField;
			}
			set
			{
				this.sFTP_AddressField = value;
				this.RaisePropertyChanged("SFTP_Address");
			}
		}

		[XmlElement(Order = 1)]
		public string Directory
		{
			get
			{
				return this.directoryField;
			}
			set
			{
				this.directoryField = value;
				this.RaisePropertyChanged("Directory");
			}
		}

		[XmlElement(Order = 2)]
		public string User_ID
		{
			get
			{
				return this.user_IDField;
			}
			set
			{
				this.user_IDField = value;
				this.RaisePropertyChanged("User_ID");
			}
		}

		[XmlElement("Password", typeof(string), Order = 3), XmlElement("SSH_Authentication_Reference", typeof(x509_Private_Key_PairObjectType), Order = 3)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 4)]
		public bool Use_Temp_File
		{
			get
			{
				return this.use_Temp_FileField;
			}
			set
			{
				this.use_Temp_FileField = value;
				this.RaisePropertyChanged("Use_Temp_File");
			}
		}

		[XmlIgnore]
		public bool Use_Temp_FileSpecified
		{
			get
			{
				return this.use_Temp_FileFieldSpecified;
			}
			set
			{
				this.use_Temp_FileFieldSpecified = value;
				this.RaisePropertyChanged("Use_Temp_FileSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Block_Size
		{
			get
			{
				return this.block_SizeField;
			}
			set
			{
				this.block_SizeField = value;
				this.RaisePropertyChanged("Block_Size");
			}
		}

		[XmlIgnore]
		public bool Block_SizeSpecified
		{
			get
			{
				return this.block_SizeFieldSpecified;
			}
			set
			{
				this.block_SizeFieldSpecified = value;
				this.RaisePropertyChanged("Block_SizeSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Block_Size_Name
		{
			get
			{
				return this.block_Size_NameField;
			}
			set
			{
				this.block_Size_NameField = value;
				this.RaisePropertyChanged("Block_Size_Name");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
