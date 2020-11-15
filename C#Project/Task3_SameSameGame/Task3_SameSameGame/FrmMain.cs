using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_SameSameGame
{
    public partial class FrmMain : Form
    {
        int[,] m_nBlock;
        int[] m_nSel;               // 선택된 블럭(인접한 같은 모양의 블럭) 저장
        bool[,] m_bVisit;           // 방문했는지 표시
        int m_nSameCnt;             // 인접한 같은 모양의 개수

        private int maxY { get; set; }
        private int maxX { get; set; }
        
        // 블록 개수
        private int m_nBlockCnt { get; set; }
        // 점수
        private int m_nScore { get; set; }

        private int m_nPointBlock { get; set; }
        private int m_nPointIndex { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        // 처음 시작
        private void FrmMain_Load(object sender, EventArgs e)
        {
            maxX = 20;
            maxY = 10;
            m_nBlock = new int[maxX, maxY];
            m_nSel = new int[maxX * maxY];
            m_bVisit = new bool[maxX, maxY];
            
        }

        private void FindSameBlock(int nX, int nY)
        {
            // 위로찾기
            if(nY>0)
            {
                if((m_nBlock[nX,nY-1]==m_nPointBlock)&&m_bVisit[nX,nY-1]==false)
                {
                    m_nSel[m_nSameCnt] = (nY - 1) * maxX + nX; // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX, nY - 1] = true;
                    FindSameBlock(nX, nY -1);
                }
            }
            if(nY<maxY-1)
            {
                if ((m_nBlock[nX, nY+1] == m_nPointBlock) && m_bVisit[nX, nY + 1] == false)
                {
                    m_nSel[m_nSameCnt] = (nY + 1) * maxX + nX; // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX, nY + 1] = true;
                    FindSameBlock(nX, nY + 1);
                }
            }
            if (nX > 0)
            {
                if ((m_nBlock[nX-1, nY] == m_nPointBlock) && m_bVisit[nX-1, nY] == false)
                {
                    m_nSel[m_nSameCnt] = nY* maxX + (nX-1); // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX-1, nY] = true;
                    FindSameBlock(nX-1, nY);
                }
            }
            if (nX < maxX-1)
            {
                if ((m_nBlock[nX + 1, nY] == m_nPointBlock) && m_bVisit[nX + 1, nY] == false)
                {
                    m_nSel[m_nSameCnt] = nY * maxX + (nX + 1); // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX + 1, nY] = true;
                    FindSameBlock(nX + 1, nY);
                }
            }
        }
        private void MoveY()
        {
            int i, j;
            int nIndex;
            int nX, nY;
            bool[] bX = new bool[maxX];

            // 빈칸을 정리
            for(i=0;i<m_nSameCnt;i++)
            {
                nIndex = m_nSel[i];

                nX = nIndex % maxX;
                nY = (int)(nIndex / 20);

                int nEmptyY;
                nEmptyY = -1;

                // 아래에서 위쪽으로 빈칸을 찾는다.
                // 찾은 빈칸의 위에도 계속 빈칸이면 무시한다.
                for(j=9;j>0;j--)
                {
                    if(m_nBlock[nX,j]==-1&&m_nBlock[nX,j-1]!=-1)
                    {
                        if(m_nBlock[nX,j]==-1 && m_nBlock[nX, j-1]!=-1)
                        {
                            nEmptyY = j;
                            break;
                        }
                    }
                }

                // 빈칸을 찾은 경우
                if(nEmptyY !=-1)
                {
                    //그림을 한 칸씩 아래로 내려준다.
                    for(j=nEmptyY;j>0;j--)
                    {
                        m_nBlock[nX, j] = m_nBlock[nX, j - 1];
                    }
                    m_nBlock[nX, 0] = -1;
                }
            }
            PictureBox pic;

            // 정리된 결과를 화면에 출력
            for(i=0;i<m_nSameCnt;i++)
            {
                nIndex = m_nSel[i] % maxX;
                nX = nIndex % maxX;
                nY = (int)(nIndex / maxX);

                if(bX[nX]==false)
                {
                    bX[nX] = true;

                    // -1이 저장된 컨트롤의 Visible을 false, 아닌것을 True
                    for(j=9;j>=0;j--)
                    {
                        if(m_nBlock[nX,j]==-1)
                        {
                            //그림을 지우고
                            panMain.Controls[j * maxX + nX].Visible = false;
                        }
                        else
                        {
                            if(panMain.Controls[j*maxX+nX].Visible == false)
                            {
                                // 그림을 지우고
                                panMain.Controls[j * maxX + nX].Visible = true;
                            }
                            else // 그림을 다시 채운다.
                            {
                                if (panMain.Controls[j * maxX + nX].Visible == false)
                                    panMain.Controls[j * maxX + nX].Visible = true;
                                pic = (PictureBox)panMain.Controls[j * maxX + nX];
                                pic.Image = imglstBlock.Images[m_nBlock[nX, j]];

                            }
                        }
                    }
                }
            }
        }

        private void MoveX()
        {
            int i, j;
            int nIndex;
            int nX, nY;
            bool bY;
            int nMinX;

            nMinX = maxX-1;
            bY = false;

            for(i=0;i<m_nSameCnt;i++)
            {
                nIndex = m_nSel[i];

                nX = nIndex % maxX;
                nY = (int)(nIndex / maxX);

                // 맨 아래칸이 삭제된 경우
                if(nY==maxY-1)
                {
                    int nEmptyX;
                    nEmptyX = -1;
                    for(j=0;j<maxX-1;j++)
                    {
                        if(m_nBlock[j,9] == -1 && m_nBlock[j+1,9]!=-1)
                        {
                            nEmptyX = j;
                            if(nMinX > nEmptyX)
                            {
                                nMinX = nEmptyX;
                                break;
                            }
                        }
                    }
                    // 오른쪽의 블럭을 옮긴다.
                    if(nEmptyX != -1)
                    {
                        bY = true;
                        int k;
                        for(j=nEmptyX;j<maxX;j++)
                        {
                            for(k=0;k<maxY;k++)
                            {
                                if(j==maxX-1)
                                {
                                    m_nBlock[j, k] = -1;
                                }
                                else
                                {
                                    m_nBlock[j, k] = m_nBlock[j + 1, k];
                                }
                            }
                        }
                    }
                }
            }

            // 빈칸이 없음 블럭을 옮길 필요가 없다
            if (bY == false) return;

            PictureBox pic;
            for (i = nMinX; i < maxX; i++)
            {
                for (j = 0; j < maxY; j++)
                {
                    nIndex = i + j * maxX;
                    pic = (PictureBox)panMain.Controls[nIndex];
                    if (m_nBlock[i, j] == -1) // 빈칸일 경우 visible을 flase로
                    {
                        if (pic.Visible)
                            pic.Visible = false;
                    }
                    else // 빈칸이 아닐 경우 맞는 그림을 보여준다.
                    {
                        if (pic.Visible == false)
                        {
                            pic.Visible = true;
                        }
                        pic.Image = imglstBlock.Images[m_nBlock[i, j]];
                    }
                }
            }
        }

        // 게임이 끝났는지 검사
        // 인접한 같은 블럭이 하나라도 있으면 끝난것이 아니다.
        private bool isGameEnd()
        {
            int i = 0, j = 0;

            for(i=1;i<maxX-1;i++)
            {
                for(j=1;j<maxY-1;j++)
                {
                    // 왼쪽, 오른쪽, 위, 아래 순으로 검사
                    if(m_nBlock[i,j]!=-1)
                    {
                        if (m_nBlock[i, j] == m_nBlock[i - 1, j]) return false;
                        if (m_nBlock[i, j] == m_nBlock[i + 1, j]) return false;
                        if (m_nBlock[i, j] == m_nBlock[i , j -1]) return false;
                        if (m_nBlock[i, j] == m_nBlock[i , j +1]) return false;
                    }
                }
            }
            MessageBox.Show("Game End!");
            return true;
        }

        // 점수 구하는 공식 :(같은 블록 개수 -2)*(같은 블록 개수 -2);
        // 점수 보여주기
        private void SetScore()
        {
            String strScore;
            int i, nCnt;

            strScore = m_nScore.ToString();
            nCnt = strScore.Length;
            // 자리수 맞추기
            for(i=0;i<5-nCnt;i++)
            {
                strScore = "0" + strScore;
            }
            picScore1.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(4, 1))];
            picScore2.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(3, 1))];
            picScore3.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(2, 1))];
            picScore4.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(1, 1))];
            picScore5.Image = imglstNum.Images[Convert.ToInt32(strScore.Substring(0, 1))];
        }

        // 남은 블럭 개수 보여주기
        private void SetBlock()
        {
            String strBlock;
            int i, nCnt;
            strBlock = m_nBlockCnt.ToString();
            nCnt = strBlock.Length;
            for(i=0;i<3-nCnt;i++)
            {
                strBlock = "0" + strBlock;
            }

            picBlock1.Image = imglstNum.Images[Convert.ToInt32(strBlock.Substring(2, 1))];
            picBlock2.Image = imglstNum.Images[Convert.ToInt32(strBlock.Substring(1, 1))];
            picBlock3.Image = imglstNum.Images[Convert.ToInt32(strBlock.Substring(0, 1))];
        }
        private void MakePicCtrl(int nIndex)
        {
            PictureBox pic = new PictureBox();
            Point pos = new Point();
            //int nRndNum;
            int n_Size = 24;
            int nX, nY;

            // 인덱스를 배열의 x,y 위치로 변환
            nX = nIndex % maxX;
            nY = (int)(nIndex / maxX);

            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            // tag에 컨트롤의 인덱스를 저장
            pic.Tag = nIndex.ToString();
            pic.Size = new Size(n_Size, n_Size); // 크기

            // 위치 저장
            pic.Location = new Point((nX*n_Size),(nY * n_Size));
            panMain.Controls.Add(pic); // 패널에 추가

            // 클릭, 더블클릭 이벤트와 연결
            pic.Click += new System.EventHandler(Ctrl_Click);
            pic.MouseMove += new System.Windows.Forms.MouseEventHandler(Ctrl_MouseMove);
        }

        // 게임 초기화
        private void initGame()
        {
            int i = 0,j;
            //int nCnt;
            int nRndNum;
            PictureBox pic;

            // 픽쳐박스 설정
            Control.ControlCollection myCtrl = panMain.Controls;

            foreach( Control ctl in myCtrl)
            {
                pic = (System.Windows.Forms.PictureBox)ctl;
                pic.Visible = true;

                // 블럭 종류 암기(랜덤하게)
                nRndNum = GetRndBlock();
                // 실제 이미지 설정

                pic.Image = imglstBlock.Images[nRndNum];
                // 이미지에 맞는 숫자를 배열에 설정
                m_nBlock[i % maxX, (int)(i / maxX)] = nRndNum;
                m_nSel[i] = -1;
                i++;
            }

            m_nPointBlock = -1;
            m_nPointIndex = -1;

            m_nBlockCnt = maxX*maxY;
            m_nScore = 0;
            for (j = 0; j < m_nBlockCnt; j++)
            {
                MakePicCtrl(j);
            }
            SetScore();
            SetBlock();
        }

        private int GetRndBlock()
        {
            Random m_rnd=new Random();
            // 0에서 4까지의 숫자를 발생
            return m_rnd.Next(0, 10000)%5;
        }

        private void Ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            int nX, nY;
            int i, j;
            PictureBox pic;

            // 원본 그림을 표시한다.
            if(m_nSameCnt>1 && m_nPointBlock >=0)
            {
                for(i =0; i<m_nSameCnt;i++)
                {
                    pic = (PictureBox)panMain.Controls[m_nSel[i]];
                    pic.Image = imglstBlock.Images[m_nPointBlock];
                }
            }

            // 방문지는 false로 셋팅
            for(i=0;i<maxX;i++)
            {
                for(j=0;j<maxY;j++)
                {
                    m_bVisit[i, j] = false;
                }
            }

            pic = (PictureBox)sender;
            // 블럭의 인덱스를 얻는다
            m_nPointIndex = Convert.ToInt32(pic.Tag.ToString());

            // 인덱스를 배열의 x,y 위치로 변환
            nX = m_nPointIndex % maxX;
            nY = (int)(m_nPointIndex / maxX);

            // 블럭의 종류를 저장한다.
            m_nPointBlock = m_nBlock[nX, nY];

            if(m_nPointBlock == -1)
            {
                return;
            }

            // 방문표시를 한다
            m_bVisit[nX, nY] = true;
            m_nSameCnt = 0;
            m_nSel[m_nSameCnt] = m_nPointIndex;
            m_nSameCnt += 1;

            // 인접한 같은 블록들을 찾는다.
            FindSameBlock(nX, nY);
            if(m_nSameCnt>1 && m_nPointBlock >=0)
            {
                for(i=0;i<m_nSameCnt;i++)
                {
                    pic = (PictureBox)panMain.Controls[m_nSel[i]];
                    pic.Image = imglstSel.Images[m_nPointBlock];
                }
            }
        }
        private void Ctrl_Click(object sender, EventArgs e)
        {
            int i;
            int nX, nY;
            int nIndex;

            // 블럭을 삭제(-1 저장) 한다.
            if(m_nSameCnt>1&&m_nPointBlock>=0)
            {
                for(i=0;i<m_nSameCnt;i++)
                {
                    nIndex = m_nSel[i];
                    // 지워진 블럭에 -1을 저장한다.
                    nX = nIndex % maxX;
                    nY = (int)(nIndex / maxX);
                    m_nBlock[nX, nY] = -1;
                }
                // 블럭들의 위치를 재설정한다.
                MoveX();
                MoveY();

                //점수 및 남은블럭 계산
                m_nBlockCnt -= m_nSameCnt;
                SetBlock();
                m_nScore += (m_nSameCnt - 2) * (m_nSameCnt - 2);
                SetScore();

                if(isGameEnd())
                {
                    if(MessageBox.Show("게임이 끝났습니다. 다시시작하겠습니까?","셈셈게임",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                    {
                        initGame();
                    }
                }
            }
            m_nSameCnt = -1;
            m_nPointIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int i;
            initGame();
        }
    }
}
